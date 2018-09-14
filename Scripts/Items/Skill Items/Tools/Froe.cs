using Server.Engines.Craft;

namespace Server.Items
{
	public class Froe : BaseTool
	{
		public override CraftSystem CraftSystem => DefCarpentry.CraftSystem;

		[Constructible]
		public Froe() : base( 0x10E5 )
		{
			Weight = 1.0;
		}

		[Constructible]
		public Froe( int uses ) : base( uses, 0x10E5 )
		{
			Weight = 1.0;
		}

		public Froe( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}
