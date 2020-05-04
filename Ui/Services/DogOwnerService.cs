using System.Collections.Generic;
using Ui.Data;
using Ui.Entities;

namespace Ui.Services
{
	public class DogOwnerService
	{
		public IDogOwnerRepository _dogOwnerRepository;

		public DogOwnerService(IDogOwnerRepository dogOwnerRepository)
		{
			_dogOwnerRepository = dogOwnerRepository;
		}
		public List<DogOwner> GetAllDogOwners()
		{
			//var dogOwnerRepository = new DogOwnerRepository();
			//var dogOwnerList = dogOwnerRepository.GetAllDogOwners();

			//return dogOwnerList;
			return _dogOwnerRepository.GetAllDogOwners();
		}
	}
}