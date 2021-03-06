namespace Server.Items
{
  public class ScribeBag : Bag
  {
    [Constructible]
    public ScribeBag(int amount = 5000)
    {
      Hue = 0x105;
      DropItem(new BagOfReagents(amount));
      DropItem(new BlankScroll(amount));
    }

    public ScribeBag(Serial serial) : base(serial)
    {
    }

    public override string DefaultName => "a Scribe Kit";

    public override void Serialize(GenericWriter writer)
    {
      base.Serialize(writer);

      writer.Write(0); // version
    }

    public override void Deserialize(GenericReader reader)
    {
      base.Deserialize(reader);

      int version = reader.ReadInt();
    }
  }
}
