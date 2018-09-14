using Server.Mobiles;
using Server.Network;
using Server.Gumps;

namespace Server.Items
{
	public class HairRestylingDeed : Item
	{
		public override int LabelNumber => 1041061; // a coupon for a free hair restyling

		[Constructible]
		public HairRestylingDeed() : base( 0x14F0 )
		{
			Weight = 1.0;
			LootType = LootType.Blessed;
		}

		public HairRestylingDeed( Serial serial ) : base( serial )
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

		public override void OnDoubleClick( Mobile from )
		{
			if ( !IsChildOf( from.Backpack ) )
			{
				from.SendLocalizedMessage( 1042001 ); // That must be in your pack...
			}
			else
			{
				from.SendGump( new InternalGump( from, this ) );
			}
		}

		private class InternalGump : Gump
		{
			private Mobile m_From;
			private HairRestylingDeed m_Deed;

			public InternalGump( Mobile from, HairRestylingDeed deed ) : base( 50, 50 )
			{
				m_From = from;
				m_Deed = deed;

				from.CloseGump( typeof( InternalGump ) );

				AddBackground( 100, 10, 400, 385, 0xA28 );

				AddHtmlLocalized( 100, 25, 400, 35, 1013008, false, false );
				AddButton( 175, 340, 0xFA5, 0xFA7, 0x0, GumpButtonType.Reply, 0 ); // CANCEL

				AddHtmlLocalized( 210, 342, 90, 35, 1011012, false, false );// <CENTER>HAIRSTYLE SELECTION MENU</center>

				int[][] RacialData = (from.Race == Race.Human) ? HumanArray : ElvenArray;

				for(int i=1; i<RacialData.Length; i++)
				{
					AddHtmlLocalized( LayoutArray[i][2], LayoutArray[i][3], (i==1) ? 125 : 80, (i==1) ? 70 : 35, (m_From.Female) ? RacialData[i][0] : RacialData[i][1], false, false );
					if ( LayoutArray[i][4] != 0 )
					{
						AddBackground( LayoutArray[i][0], LayoutArray[i][1], 50, 50, 0xA3C );
						AddImage( LayoutArray[i][4], LayoutArray[i][5], (m_From.Female) ? RacialData[i][4] : RacialData[i][5] );
					}
					AddButton( LayoutArray[i][6], LayoutArray[i][7], 0xFA5, 0xFA7, i, GumpButtonType.Reply, 0 );
				}
			}

			public override void OnResponse( NetState sender, RelayInfo info )
			{
				if ( m_From == null || !m_From.Alive )
					return;

				if ( m_Deed.Deleted )
					return;

				if ( info.ButtonID < 1 || info.ButtonID > 10 )
					return;

				int[][] RacialData = (m_From.Race == Race.Human) ? HumanArray : ElvenArray;

				if ( m_From is PlayerMobile pm )
				{
					pm.SetHairMods( -1, -1 ); // clear any hairmods (disguise kit, incognito)
					pm.HairItemID = (pm.Female) ? RacialData[info.ButtonID][2] : RacialData[info.ButtonID][3];
					m_Deed.Delete();
				}
			}
/*
		gump data: bgX, bgY, htmlX, htmlY, imgX, imgY, butX, butY
*/

			int[][] LayoutArray =
			{
				new int[] { 0 }, /* padding: its more efficient than code to ++ the index/buttonid */
				new int[] { 425, 280, 342, 295, 000, 000, 310, 292 },
				new int[] { 235, 060, 150, 075, 168, 020, 118, 073 },
				new int[] { 235, 115, 150, 130, 168, 070, 118, 128 },
				new int[] { 235, 170, 150, 185, 168, 130, 118, 183 },
				new int[] { 235, 225, 150, 240, 168, 185, 118, 238 },
				new int[] { 425, 060, 342, 075, 358, 018, 310, 073 },
				new int[] { 425, 115, 342, 130, 358, 075, 310, 128 },
				new int[] { 425, 170, 342, 185, 358, 125, 310, 183 },
				new int[] { 425, 225, 342, 240, 358, 185, 310, 238 },
				new int[] { 235, 280, 150, 295, 168, 245, 118, 292 } // slot 10, Curly - N/A for elfs.
			};

/*
		racial arrays are: cliloc_F, cliloc_M, ItemID_F, ItemID_M, gump_img_F, gump_img_M
*/
			int[][] HumanArray = /* why on earth cant these utilies be consistent with hex/dec */
			{
				new int[] { 0 },
				new int[] { 1011064, 1011064, 0, 0, 0, 0  },  // bald
				new int[] { 1011052, 1011052, 0x203B, 0x203B, 0xed1c, 0xC60C }, // Short
				new int[] { 1011053, 1011053, 0x203C, 0x203C, 0xed1d, 0xc60d }, // Long
				new int[] { 1011054, 1011054, 0x203D, 0x203D, 0xed1e, 0xc60e }, // Ponytail
				new int[] { 1011055, 1011055, 0x2044, 0x2044, 0xed27, 0xC60F }, // Mohawk
				new int[] { 1011047, 1011047, 0x2045, 0x2045, 0xED26, 0xED26 }, // Pageboy
				new int[] { 1074393, 1011048, 0x2046, 0x2048, 0xed28, 0xEDE5 }, // Buns, Receding
				new int[] { 1011049, 1011049, 0x2049, 0x2049, 0xede6, 0xede6 }, // 2-tails
				new int[] { 1011050, 1011050, 0x204A, 0x204A, 0xED29, 0xED29 }, // Topknot
				new int[] { 1011396, 1011396, 0x2047, 0x2047, 0xed25, 0xc618 }  // Curly
			};
			int[][] ElvenArray =
			{
				new int[] { 0 },
				new int[] { 1011064, 1011064, 0, 0, 0, 0, },  // bald
				new int[] { 1074386, 1074386, 0x2fc0, 0x2fc0, 0xedf5, 0xc6e5 }, // long feather
				new int[] { 1074387, 1074387, 0x2fc1, 0x2fc1, 0xedf6, 0xc6e6 }, // short
				new int[] { 1074388, 1074388, 0x2fc2, 0x2fc2, 0xedf7, 0xc6e7 }, // mullet
				new int[] { 1074391, 1074391, 0x2fce, 0x2fce, 0xeddc, 0xc6cc }, // knob
				new int[] { 1074392, 1074392, 0x2fcf, 0x2fcf, 0xeddd, 0xc6cd }, // braided
				new int[] { 1074394, 1074394, 0x2fd1, 0x2fd1, 0xeddf, 0xc6cf }, // spiked
				new int[] { 1074389, 1074385, 0x2fcc, 0x2fbf, 0xedda, 0xc6e4 }, // flower, mid-long
				new int[] { 1074393, 1074390, 0x2fd0, 0x2fcd, 0xedde, 0xc6cb }  // buns, long
			};
		}
	}
}
