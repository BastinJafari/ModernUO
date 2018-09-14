namespace Server.Items
{
	public class FruitBasket : Food
	{
		[Constructible]
		public FruitBasket() : base( 1, 0x993 )
		{
			Weight = 2.0;
			FillFactor = 5;
			Stackable = false;
		}

		public FruitBasket( Serial serial ) : base( serial )
		{
		}

		public override bool Eat( Mobile from )
		{
			if ( !base.Eat( from ) )
				return false;

			from.AddToBackpack( new Basket() );
			return true;
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

	[FlippableAttribute( 0x171f, 0x1720 )]
	public class Banana : Food
	{
		[Constructible]
		public Banana() : this( 1 )
		{
		}

		[Constructible]
		public Banana( int amount ) : base( amount, 0x171f )
		{
			this.Weight = 1.0;
			this.FillFactor = 1;
		}

		public Banana( Serial serial ) : base( serial )
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

	[Flippable( 0x1721, 0x1722 )]
	public class Bananas : Food
	{
		[Constructible]
		public Bananas() : this( 1 )
		{
		}

		[Constructible]
		public Bananas( int amount ) : base( amount, 0x1721 )
		{
			this.Weight = 1.0;
			this.FillFactor = 1;
		}

		public Bananas( Serial serial ) : base( serial )
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

	public class SplitCoconut : Food
	{
		[Constructible]
		public SplitCoconut() : this( 1 )
		{
		}

		[Constructible]
		public SplitCoconut( int amount ) : base( amount, 0x1725 )
		{
			this.Weight = 1.0;
			this.FillFactor = 1;
		}

		public SplitCoconut( Serial serial ) : base( serial )
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

	public class Lemon : Food
	{
		[Constructible]
		public Lemon() : this( 1 )
		{
		}

		[Constructible]
		public Lemon( int amount ) : base( amount, 0x1728 )
		{
			this.Weight = 1.0;
			this.FillFactor = 1;
		}

		public Lemon( Serial serial ) : base( serial )
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

	public class Lemons : Food
	{
		[Constructible]
		public Lemons() : this( 1 )
		{
		}

		[Constructible]
		public Lemons( int amount ) : base( amount, 0x1729 )
		{
			this.Weight = 1.0;
			this.FillFactor = 1;
		}

		public Lemons( Serial serial ) : base( serial )
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

	public class Lime : Food
	{
		[Constructible]
		public Lime() : this( 1 )
		{
		}

		[Constructible]
		public Lime( int amount ) : base( amount, 0x172a )
		{
			this.Weight = 1.0;
			this.FillFactor = 1;
		}

		public Lime( Serial serial ) : base( serial )
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

	public class Limes : Food
	{
		[Constructible]
		public Limes() : this( 1 )
		{
		}

		[Constructible]
		public Limes( int amount ) : base( amount, 0x172B )
		{
			this.Weight = 1.0;
			this.FillFactor = 1;
		}

		public Limes( Serial serial ) : base( serial )
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

	public class Coconut : Food
	{
		[Constructible]
		public Coconut() : this( 1 )
		{
		}

		[Constructible]
		public Coconut( int amount ) : base( amount, 0x1726 )
		{
			this.Weight = 1.0;
			this.FillFactor = 1;
		}

		public Coconut( Serial serial ) : base( serial )
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

	public class OpenCoconut : Food
	{
		[Constructible]
		public OpenCoconut() : this( 1 )
		{
		}

		[Constructible]
		public OpenCoconut( int amount ) : base( amount, 0x1723 )
		{
			this.Weight = 1.0;
			this.FillFactor = 1;
		}

		public OpenCoconut( Serial serial ) : base( serial )
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

	public class Dates : Food
	{
		[Constructible]
		public Dates() : this( 1 )
		{
		}

		[Constructible]
		public Dates( int amount ) : base( amount, 0x1727 )
		{
			this.Weight = 1.0;
			this.FillFactor = 1;
		}

		public Dates( Serial serial ) : base( serial )
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

	public class Grapes : Food
	{
		[Constructible]
		public Grapes() : this( 1 )
		{
		}

		[Constructible]
		public Grapes( int amount ) : base( amount, 0x9D1 )
		{
			this.Weight = 1.0;
			this.FillFactor = 1;
		}

		public Grapes( Serial serial ) : base( serial )
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

	public class Peach : Food
	{
		[Constructible]
		public Peach() : this( 1 )
		{
		}

		[Constructible]
		public Peach( int amount ) : base( amount, 0x9D2 )
		{
			this.Weight = 1.0;
			this.FillFactor = 1;
		}

		public Peach( Serial serial ) : base( serial )
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

	public class Pear : Food
	{
		[Constructible]
		public Pear() : this( 1 )
		{
		}

		[Constructible]
		public Pear( int amount ) : base( amount, 0x994 )
		{
			this.Weight = 1.0;
			this.FillFactor = 1;
		}

		public Pear( Serial serial ) : base( serial )
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

	public class Apple : Food
	{
		[Constructible]
		public Apple() : this( 1 )
		{
		}

		[Constructible]
		public Apple( int amount ) : base( amount, 0x9D0 )
		{
			this.Weight = 1.0;
			this.FillFactor = 1;
		}

		public Apple( Serial serial ) : base( serial )
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

	public class Watermelon : Food
	{
		[Constructible]
		public Watermelon() : this( 1 )
		{
		}

		[Constructible]
		public Watermelon( int amount ) : base( amount, 0xC5C )
		{
			this.Weight = 5.0;
			this.FillFactor = 5;
		}

		public Watermelon( Serial serial ) : base( serial )
		{
		}
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 1 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();

			if ( version < 1 )
			{
				if ( FillFactor == 2 )
					FillFactor = 5;

				if ( Weight == 2.0 )
					Weight = 5.0;
			}
		}
	}

	public class SmallWatermelon : Food
	{
		[Constructible]
		public SmallWatermelon() : this( 1 )
		{
		}

		[Constructible]
		public SmallWatermelon( int amount ) : base( amount, 0xC5D )
		{
			this.Weight = 5.0;
			this.FillFactor = 5;
		}

		public SmallWatermelon( Serial serial ) : base( serial )
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

	[FlippableAttribute( 0xc72, 0xc73 )]
	public class Squash : Food
	{
		[Constructible]
		public Squash() : this( 1 )
		{
		}

		[Constructible]
		public Squash( int amount ) : base( amount, 0xc72 )
		{
			this.Weight = 1.0;
			this.FillFactor = 1;
		}

		public Squash( Serial serial ) : base( serial )
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

	[FlippableAttribute( 0xc79, 0xc7a )]
	public class Cantaloupe : Food
	{
		[Constructible]
		public Cantaloupe() : this( 1 )
		{
		}

		[Constructible]
		public Cantaloupe( int amount ) : base( amount, 0xc79 )
		{
			this.Weight = 1.0;
			this.FillFactor = 1;
		}

		public Cantaloupe( Serial serial ) : base( serial )
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