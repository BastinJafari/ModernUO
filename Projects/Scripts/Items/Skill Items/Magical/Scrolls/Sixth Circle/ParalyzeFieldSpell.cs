namespace Server.Items
{
  public class ParalyzeFieldScroll : SpellScroll
  {
    [Constructible]
    public ParalyzeFieldScroll(int amount = 1) : base(46, 0x1F5B, amount)
    {
    }

    public ParalyzeFieldScroll(Serial serial) : base(serial)
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
