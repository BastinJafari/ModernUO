namespace Server.Items
{
  public class ManaDrainScroll : SpellScroll
  {
    [Constructible]
    public ManaDrainScroll(int amount = 1) : base(30, 0x1F4B, amount)
    {
    }

    public ManaDrainScroll(Serial serial) : base(serial)
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
