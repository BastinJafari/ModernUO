namespace Server.Items
{
	[Flippable( 0x3D8E, 0x3D8F )]
	public class LargeFishingNetComponent : AddonComponent
	{
		public override int LabelNumber => 1076285; // Large Fish Net

		public LargeFishingNetComponent() : base( 0x3D8E )
		{
		}

		public LargeFishingNetComponent( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.WriteEncodedInt( 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadEncodedInt();
		}
	}

	public class LargeFishingNetAddon : BaseAddon
	{
		public override BaseAddonDeed Deed => new LargeFishingNetDeed();

		[Constructible]
		public LargeFishingNetAddon()
		{
			AddComponent( new LargeFishingNetComponent(), 0, 0, 0 );
		}

		public LargeFishingNetAddon( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.WriteEncodedInt( 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadEncodedInt();
		}
	}

	public class LargeFishingNetDeed : BaseAddonDeed
	{
		public override BaseAddon Addon => new LargeFishingNetAddon();
		public override int LabelNumber => 1076285; // Large Fish Net

		[Constructible]
		public LargeFishingNetDeed()
		{
			LootType = LootType.Blessed;
		}

		public LargeFishingNetDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.WriteEncodedInt( 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadEncodedInt();
		}
	}
}
