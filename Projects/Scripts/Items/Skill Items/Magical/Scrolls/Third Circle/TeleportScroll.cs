namespace Server.Items
{
  public class TeleportScroll : SpellScroll
  {
    [Constructible]
    public TeleportScroll(int amount = 1) : base(21, 0x1F42, amount)
    {
    }

    public TeleportScroll(Serial serial) : base(serial)
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
