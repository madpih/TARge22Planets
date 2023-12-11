using MauiPlanets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiPlanets.Services
{
	internal static class PlanetsService
	{
		private static List<Planet> planets = new()
		{
			new()
			{
				Name = "Mercury",
				Subtitle = " The smallest planet",
				HeroImage = "mercury.png",
				Description = "Mercury—the smallest planet in our solar system and nearest to the Sun—is only slightly larger than Earth's Moon." +
				" Its surface is covered in tens of thousands of impact craters." +
				"From the surface of Mercury, the Sun would appear more than three times as large as it does when viewed" +
				" from Earth, and the sunlight would be as much as 11 times brighter. Despite its proximity to the Sun," +
				" Mercury is not the hottest planet in our solar system— that title belongs to nearby Venus, thanks to its dense atmosphere." +
				" But Mercury is the fastest planet, zipping around the Sun every 88 Earth days." +
				" Mercury is appropriately named for the swiftest of the" +
				" ancient Roman gods.",
				AccentColorStart = Color.FromArgb("#353535"),
				AccentColorEnd = Color.FromArgb("#8d9098"),
				Images = new()
				{
					"https://science.nasa.gov/_ipx/w_1536&f_webp/https://smd-cms.nasa.gov/wp-content/uploads/2023/04/EW0108829708G4release_mercury-jpg.webp",
					"https://science.nasa.gov/_ipx/w_1536&f_webp/https://smd-cms.nasa.gov/wp-content/uploads/2023/05/pia19285-mercury-jpg.webp",
					"https://science.nasa.gov/_ipx/w_1536&f_webp/https://smd-cms.nasa.gov/wp-content/uploads/2023/05/pia19422-mercury.jpg"
				}
			},
			new()
			{
				Name = " Venus",
				Subtitle = " The hottet planet",
				HeroImage = "venus.png",
				Description = "Venus is a cloud-swaddled planet named for a love goddess, and often called Earth’s twin." +
				" But pull up a bit closer, and Venus turns hellish. Our nearest planetary neighbor, the second planet from" +
				" the Sun, has a surface hot enough to melt lead. The atmosphere is so thick that, from the surface," +
				" the Sun is just a smear of light. In some ways it is more an opposite of Earth than a twin:" +
				" Venus spins backward, has a day longer than its year, and lacks any semblance of seasons." +
				" It might once have been a habitable ocean world, like Earth, but that was at least a billion years ago." +
				" A runaway greenhouse effect turned all surface water into vapor, which then leaked slowly into space." +
				" The present-day surface of volcanic rock is blasted by high temperatures and pressures." +
				" Asked if the surface of Venus is likely to be life-bearing today, we can give a quick answer: a hard “no.”",
				AccentColorStart = Color.FromArgb("#a6393b"),
				AccentColorEnd = Color.FromArgb("#d17f21"),
				Images = new()
				{
					"https://science.nasa.gov/_ipx/w_1536&f_webp/https://images-assets.nasa.gov/image/PIA00271/PIA00271~large.jpg%3Fw=1920%26h=1920%26fit=clip%26crop=faces%252Cfocalpoint",
					"https://science.nasa.gov/_ipx/w_1536&f_webp/https://smd-cms.nasa.gov/wp-content/uploads/2023/05/venus-single.png",
					"https://cosmosmagazine.com/wp-content/uploads/2023/10/GettyImages-1199281415.jpg"
				}
			},
			new()
			{
				Name = " Earth",
				Subtitle = " Our home planet",
				HeroImage = "earth.png",
				Description = "While Earth is only the fifth largest planet in the solar system, it is the only world in our solar system" +
				" with liquid water on the surface. Just slightly larger than nearby Venus, Earth is the biggest of the" +
				" four planets closest to the Sun, all of which are made of rock and metal." +
				" Earth is the only planet in the Solar System whose English name does not come from Greek or Roman mythology." +
				" The name was taken from Old English and Germanic. It simply means \"the ground.\" " +
				"There are, of course, many names for our planet in the thousands of languages spoken by the people of the third planet from the Sun.",
				AccentColorStart = Color.FromArgb("#0e3d68"),
				AccentColorEnd = Color.FromArgb("#2e97c7"),
				Images = new()
				{
					"https://images.unsplash.com/photo-1614730321146-b6fa6a46bcb4?q=80&w=1974&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
					"https://www.worldatlas.com/upload/20/19/6e/shutterstock-1685545819.jpg",
					"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQANo_kX3Qj5fBhprdLTgl741KKW-UR1A5ubWRMntqkUFZvf2OG9l7ejTtcRYL3QLEBbe0&usqp=CAU"
				}
			},

			new()
			{
				Name = " Mars",
				Subtitle = " The Red Planet",
				HeroImage = "mars.png",
				Description = "Mars is no place for the faint-hearted. It’s dry, rocky, and bitter cold." +
				" The fourth planet from the Sun, Mars is one of Earth's two closest planetary neighbors (Venus is the other)." +
				" Mars is one of the easiest planets to spot in the night sky – it looks like a bright red point of light.",
				AccentColorStart = Color.FromArgb("#0e3d68"),
				AccentColorEnd = Color.FromArgb("#2e97c7"),
				Images = new()
				{
					"https://media.cnn.com/api/v1/images/stellar/prod/181115180453-01-mars-best-moments-mars-globe-valles-marineris-enhanced.jpg?q=w_1576,c_fill",
					"https://cdn.britannica.com/64/73464-050-56C80D3A/view-composite-images-Mars-spacecraft-Global-Surveyor-April-1999.jpg",
					"https://media.cnn.com/api/v1/images/stellar/prod/210511145919-perseverance-mars-rover-0429.jpg?q=w_2068,h_1172,x_0,y_0,c_fill/h_618"
				}
			},

			new()
			{
				Name = " Jupiter",
				Subtitle = " The Biggest",
				HeroImage = "jupiter.png",
				Description = "Jupiter is the fifth planet from our Sun and is, by far, the largest planet in the solar system – more than twice as massive as all the other planets combined.\r\n\r\nJupiter's stripes and swirls are actually cold, windy clouds of ammonia and water, floating in an atmosphere of hydrogen and helium. Jupiter’s iconic Great Red Spot is a giant storm bigger than Earth that has raged for hundreds of years.\r\n\r\nJupiter is named for the king of the ancient Roman gods.​",
				AccentColorStart = Color.FromArgb("#9d4a408"),
				AccentColorEnd = Color.FromArgb("#cd8026"),
				Images = new()
				{
				"https://science.nasa.gov/_ipx/w_1536&f_webp/https://images-assets.nasa.gov/image/PIA24818/PIA24818~orig.jpg%3Fw=766%26h=696%26fit=clip%26crop=faces%252Cfocalpoint",
				"https://universemagazine.com/wp-content/uploads/2023/10/photo_2023-10-26_22-32-59.jpg",
				}
			},
			new()
			{
				Name = " Saturn",
				Subtitle = " The ring planet",
				HeroImage = "saturn.png",
				Description = "Saturn is the sixth planet from the Sun and the second largest planet in our solar system." +
				" Adorned with a dazzling system of icy rings, Saturn is unique among the planets.\r\n\r\nIt is not the only planet to have rings" +
				", but none are as spectacular or as complex as Saturn's. Like fellow gas giant Jupiter, Saturn" +
				" is a massive ball made mostly of hydrogen and helium.\r\n\r\nThe farthest planet from Earth" +
				" discovered by the unaided human eye, Saturn has been known since ancient times." +
				" The planet is named for the Roman god of agriculture and wealth, who was also the father of Jupiter.",
				AccentColorStart = Color.FromArgb("#996237"),
				AccentColorEnd = Color.FromArgb("#c6502f"),
				Images = new()
				{
					"https://science.nasa.gov/_ipx/w_1536&f_webp/https://images-assets.nasa.gov/image/PIA03152/PIA03152~orig.jpg%3Fw=849%26h=900%26fit=clip%26crop=faces%252Cfocalpoint",
					"https://science.nasa.gov/_ipx/w_1536&f_webp/https://images-assets.nasa.gov/image/PIA11141/PIA11141~large.jpg%3Fw=1920%26h=929%26fit=clip%26crop=faces%252Cfocalpoint",
				}
			},
			new()
			{
				Name = " Uranus",
				Subtitle = " The Herchel planet",
				HeroImage = "uranus.png",
				Description = "Uranus is very cold and windy. It is surrounded by faint rings and more than two dozen small moons as it rotates at a nearly 90-degree angle from the plane of its orbit." +
				" This unique tilt makes Uranus appear to spin on its side.\r\n\r\nUranus is blue-green in color due to large amounts of methane," +
				" which absorbs red light but allows blues to be reflected back into space. The atmosphere is mostly hydrogen and helium," +
				" but also includes large amounts of water, ammonia and methane.",
				AccentColorStart = Color.FromArgb("#9d4a40"),
				AccentColorEnd = Color.FromArgb("#996237"),
				Images = new()
				{
					"https://science.nasa.gov/_ipx/w_1536&f_webp/https://images-assets.nasa.gov/image/PIA00143/PIA00143~orig.jpg%3Fw=794%26h=960%26fit=clip%26crop=faces%252Cfocalpoint",
					"https://science.nasa.gov/_ipx/w_1536&f_webp/https://images-assets.nasa.gov/image/0301099/0301099~large.jpg%3Fw=1920%26h=1772%26fit=clip%26crop=faces%252Cfocalpoint",
					"https://cdn-ssl.funkidslive.com/wp-content/uploads/2022/10/yto1u-i1pvi-1536x877.jpg"
				}
			},
			new()
			{
				Name = " Neptune",
				Subtitle = " The god of the sea",
				HeroImage = "neptune.png",
				Description = "Dark, cold and whipped by supersonic winds, giant Neptune is the eighth and most distant major" +
				" planet orbiting our Sun. More than 30 times as far from the Sun as Earth, Neptune is not visible to the naked eye." +
				" In 2011, Neptune completed its first 165-year orbit since its discovery.\r\n\r\nThe planet’s rich blue color comes from" +
				" methane in its atmosphere, which absorbs red wavelengths of light but allows blue ones to be reflected back into space.",
				AccentColorStart = Color.FromArgb("#0c293d"),
				AccentColorEnd = Color.FromArgb("#26abe0"),
				Images = new()
				{
					"https://science.nasa.gov/_ipx/w_1536&f_webp/https://images-assets.nasa.gov/image/PIA01142/PIA01142~orig.jpg%3Fw=945%26h=870%26fit=clip%26crop=faces%252Cfocalpoint",
					"https://science.nasa.gov/_ipx/w_1536&f_webp/https://images-assets.nasa.gov/image/PIA02215/PIA02215~orig.jpg%3Fw=800%26h=600%26fit=clip%26crop=faces%252Cfocalpoint",
					"https://science.nasa.gov/_ipx/w_1536&f_webp/https://images-assets.nasa.gov/image/PIA00340/PIA00340~large.jpg%3Fw=1920%26h=1920%26fit=clip%26crop=faces%252Cfocalpoint"
				}
			},
			new()
			{
				Name = " Pluto",
				Subtitle = " The Star of Dwarf ",
				HeroImage = "pluto.png",
				Description = "Pluto is a complex and mysterious world with mountains, valleys, plains, craters, and apparently even glaciers. " +
				"Discovered in 1930, Pluto was long considered our solar system's ninth planet. But after the discovery that many similar," +
				" intriguing worlds inhabit the distant region beyond Neptune known as the Kuiper Belt, icy Pluto was reclassified as a dwarf planet.",
				AccentColorStart = Color.FromArgb("#0c293d"),
				AccentColorEnd = Color.FromArgb("#26abe0"),
				Images = new()
				{
				"https://cdn.shopify.com/s/files/1/0742/7719/1954/files/pluto-1_2ee72c27-ee82-4f03-ad05-084abd5d74fd_1024x1024.jpg?v=1693092850",
				"https://science.nasa.gov/_ipx/w_1536&f_webp/https://images-assets.nasa.gov/image/PIA20037/PIA20037~orig.jpg%3Fw=1041%26h=717%26fit=clip%26crop=faces%252Cfocalpoint",
				"https://science.nasa.gov/_ipx/w_1536&f_webp/https://smd-cms.nasa.gov/wp-content/uploads/2023/04/137119main2_hst_pluto1_516-jpg.webp%3Fw=516",
				"https://lirp.cdn-website.com/b905c406/dms3rep/multi/opt/stock-photo-surface-clear-image-of-pluto-1853394100-ab7240de-1920w.jpg",
				"https://lirp.cdn-website.com/b905c406/dms3rep/multi/opt/stock-photo-realistic-planet-pluto-in-the-solar-system-d-render-1654817725-09664836-1920w.jpg"
				}
			},
				new()
			{
				Name = " Ceres",
				Subtitle = " Dwarf planet",
				HeroImage = "ceres.png",
				Description = "Dwarf planet Ceres is the largest object in the asteroid belt between Mars and Jupiter," +
					" and it's the only dwarf planet located in the inner solar system." +
					"Ceres is named for the Roman goddess of corn and harvests. The word cereal comes from the same name.",
				AccentColorStart = Color.FromArgb("#0c293d"),
				AccentColorEnd = Color.FromArgb("#26abe0"),
				Images = new()
				{
				"https://www.universetoday.com/wp-content/uploads/2016/05/Ceres_-_Oxo_and_Haulani_craters.png",
				"https://cdn.mos.cms.futurecdn.net/7yojSnrjnEZHoXtA2XLHxF.jpg",
				"https://lirp.cdn-website.com/b905c406/dms3rep/multi/opt/stock-photo-ceres-dwarf-planet-isolated-on-black-background-d-render-1190826628-850466d1-1920w.jpg"
				}
			},
					new()
			{
				Name = " Makemake",
				Subtitle = " Dwarf planet",
				HeroImage = "makemake.png",
				Description = " Makemake is slightly smaller than Pluto, and is the second-brightest object in the Kuiper Belt" +
						" as seen from Earth while Pluto is the brightest." +
						" It takes about 305 Earth years for this dwarf planet to make one trip around the Sun.",
				AccentColorStart = Color.FromArgb("#0c293d"),
				AccentColorEnd = Color.FromArgb("#26abe0"),
				Images = new()
				{
				"https://theplanets.org/123/2021/11/Dwarf-Planet-Makemake.png",
				"https://cdn.shopify.com/s/files/1/0742/7719/1954/files/Makemake_1024x1024.jpg?v=1693092886"
				}
			},
						new()
			{
				Name = " Haumea",
				Subtitle = " Dwarf planet",
				HeroImage = "haumea.png",
				Description = "Haumea is roughly the same size as Pluto. It is one of the fastest rotating large objects in our solar system." +
							" The fast spin distorts Haumea's shape, making this dwarf planet look like a football. " +
							"Everything we know about Haumea is from observations with ground-based telescopes from around the world.",
				AccentColorStart = Color.FromArgb("#0c293d"),
				AccentColorEnd = Color.FromArgb("#26abe0"),
				Images = new()
				{
				"https://cdn.shopify.com/s/files/1/0742/7719/1954/files/Haumea_1024x1024.jpg?v=1693092866",
				
			
				}
			},
							new()
			{
				Name = " Eris",
				Subtitle = " Dwarf planet ",
				HeroImage = "eris.png",
				Description = "Eris is one of the largest known dwarf planets in our solar system. " +
								"It's about the same size as Pluto but is three times farther from the Sun. " +
								"At first, Eris appeared to be larger than Pluto. This triggered a debate in the scientific community that led to the International Astronomical Union's decision in 2006 to clarify the definition of a planet." +
								" Pluto, Eris, and other similar objects are now classified as dwarf planets.",
				AccentColorStart = Color.FromArgb("#0c293d"),
				AccentColorEnd = Color.FromArgb("#26abe0"),
				Images = new()
				{
				"https://cdn.shopify.com/s/files/1/0742/7719/1954/files/eris_1024x1024.jpg?v=1693092905",
				"https://nineplanets.org/wp-content/uploads/2019/11/Eris_spacepedia.png",
				"https://nineplanets.org/wp-content/uploads/2019/11/dwarf_planet_Eris-1-1024x682.jpg"
				}
			},

		};

		public static List<Planet> GetFeaturedPlanets()
		{
			var random = new Random();
			var randomizedPlanets = planets.OrderBy(item => random.Next());
			
			return randomizedPlanets.Take(2).ToList();
		}

		public static List<Planet> GetAllPlanets()
		=> planets;

		
	}
}
