namespace Server.Items
{
	public class RuneBladeOfKnowledge : RuneBlade
	{
		public override int LabelNumber => 1073539; // rune blade of knowledge

		[Constructible]
		public RuneBladeOfKnowledge()
		{
			Attributes.SpellDamage = 5;
		}

		public RuneBladeOfKnowledge( Serial serial ) : base( serial )
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
