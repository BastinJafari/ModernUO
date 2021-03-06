namespace Server.Items
{
  public class AgilityScroll : SpellScroll
  {
    [Constructible]
    public AgilityScroll(int amount = 1) : base(8, 0x1F35, amount)
    {
    }

    public AgilityScroll(Serial serial) : base(serial)
    {
    }

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
