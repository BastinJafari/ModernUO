namespace Server.Items
{
  public class Sapphire : Item
  {
    [Constructible]
    public Sapphire(int amount = 1) : base(0xF19)
    {
      Stackable = true;
      Amount = amount;
    }

    public Sapphire(Serial serial) : base(serial)
    {
    }

    public override double DefaultWeight => 0.1;


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
