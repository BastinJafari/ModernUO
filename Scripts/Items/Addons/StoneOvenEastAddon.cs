namespace Server.Items
{
	public class StoneOvenEastAddon : BaseAddon
	{
		public override BaseAddonDeed Deed => new StoneOvenEastDeed();

		[Constructible]
		public StoneOvenEastAddon()
		{
			AddComponent( new AddonComponent( 0x92C ), 0, 0, 0 );
			AddComponent( new AddonComponent( 0x92B ), 0, 1, 0 );
		}

		public StoneOvenEastAddon( Serial serial ) : base( serial )
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

	public class StoneOvenEastDeed : BaseAddonDeed
	{
		public override BaseAddon Addon => new StoneOvenEastAddon();
		public override int LabelNumber => 1044345; // stone oven (east)

		[Constructible]
		public StoneOvenEastDeed()
		{
		}

		public StoneOvenEastDeed( Serial serial ) : base( serial )
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
