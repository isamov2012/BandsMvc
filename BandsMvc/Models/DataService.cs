namespace BandsMvc.Models
{
	public class DataService
	{
		List<Band> bands = new List<Band>

		{
			new Band {Id = 5, Name = "Backstreet", Description ="Best Boy Band in the World" },
			new Band {Id = 10, Name = "Queen", Description ="Best Rock Band in the World" },
			new Band {Id = 7, Name = "Beatles", Description ="All Times Best Band" },
		};
		public Band GetBandById(int id)
		{
			var q = bands
				.First(band => band.Id == id);
			return q;


		}
		public Band[] GetAllBands()
		{
			return bands
				.ToArray();
		}

	}
}
