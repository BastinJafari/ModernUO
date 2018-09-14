namespace Server.Items
{

	public abstract class BaseWaist : BaseClothing
	{
		public BaseWaist( int itemID ) : this( itemID, 0 )
		{
		}

		public BaseWaist( int itemID, int hue ) : base( itemID, Layer.Waist, hue )
		{
		}

		public BaseWaist( Serial serial ) : base( serial )
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

	[FlippableAttribute( 0x153b, 0x153c )]
	public class HalfApron : BaseWaist
	{
		[Constructible]
		public HalfApron() : this( 0 )
		{
		}

		[Constructible]
		public HalfApron( int hue ) : base( 0x153b, hue )
		{
			Weight = 2.0;
		}

		public HalfApron( Serial serial ) : base( serial )
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

	[Flippable( 0x27A0, 0x27EB )]
	public class Obi : BaseWaist
	{
		[Constructible]
		public Obi() : this( 0 )
		{
		}

		[Constructible]
		public Obi( int hue ) : base( 0x27A0, hue )
		{
			Weight = 1.0;
		}

		public Obi( Serial serial ) : base( serial )
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

	[FlippableAttribute( 0x2B68, 0x315F )]
	public class WoodlandBelt : BaseWaist
	{
		public override Race RequiredRace => Race.Elf;

		[Constructible]
		public WoodlandBelt() : this( 0 )
		{
		}

		[Constructible]
		public WoodlandBelt( int hue ) : base( 0x2B68, hue )
		{
			Weight = 4.0;
		}

		public WoodlandBelt( Serial serial ) : base( serial )
		{
		}

		public override bool Dye( Mobile from, DyeTub sender )
		{
			from.SendLocalizedMessage( sender.FailMessage );
			return false;
		}

		public override bool Scissor( Mobile from, Scissors scissors )
		{
			from.SendLocalizedMessage( 502440 ); // Scissors can not be used on that to produce anything.
			return false;
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
