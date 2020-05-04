using System.Collections.Generic;
using Ui.Entities;

namespace Ui.Data
{
	public interface IDogOwnerRepository
	{
		List<DogOwner> GetAllDogOwners();
	}
	public class DogOwnerRepository:IDogOwnerRepository
	{
	
		public List<DogOwner> GetAllDogOwners()
		{
			var dogOwnerList = new List<DogOwner>
			{
				new DogOwner
				{
					OwnerName = "Rob",
					DogName = "Willow"
				},
				new DogOwner
				{
					OwnerName = "Rob",
					DogName = "Nook"
				},
				new DogOwner
				{
					OwnerName = "Rob",
					DogName = "Sox"
				}
			};

			return dogOwnerList;
		} 
	}
}