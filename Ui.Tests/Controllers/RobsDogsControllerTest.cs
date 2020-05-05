using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ui.Controllers;
using Ui.Models;
using Ui.ViewModelMappers;

namespace Ui.Tests.Controllers
{
	[TestClass]
	public class RobsDogsControllerTest
	{
		[TestMethod]
		public void Index()
		{
			// Arrange
			RobsDogsController controller = new RobsDogsController();

			// Act
			ViewResult result = controller.Index() as ViewResult;

			// Assert
			Assert.IsNotNull(result);
			// Should be testing/verifying call to GetAllDogOwners and subsequent methods down the stack.
			// Moq is installed to help you.
		}
		[TestMethod]
		public void DogOwnersDogCount()
		{
			var  controller = new RobsDogsController();
			var result = controller.Index() as ViewResult;
			var model = (DogOwnerListViewModel)result.Model;
			var count = model.DogOwnerViewModels.Count;
			
			Assert.AreEqual(3, count);

		}

		[TestMethod]
		public void DogOwnersName()
		{
			var controller = new RobsDogsController();
			var result = controller.Index() as ViewResult;
			var model = (DogOwnerListViewModel)result.Model;			
			string dogOwner = model.DogOwnerViewModels[0].OwnerName;
			
			Assert.AreEqual("Rob", dogOwner);
		}


		[TestMethod]
		public void ListOfDogNames()
		{
			List<string> actualDogs = new List<string>() { "Willow", "Nook", "Sox" };
			var controller = new RobsDogsController();
			var result = controller.Index() as ViewResult;
			var model = (DogOwnerListViewModel)result.Model;
			List<string> modelDogs = new List<string>()
			{ 
				model.DogOwnerViewModels[0].DogNames[0],
				model.DogOwnerViewModels[1].DogNames[0],
				model.DogOwnerViewModels[2].DogNames[0]

			};			
			Assert.AreEqual(actualDogs[0], modelDogs[0]);
			Assert.AreEqual(actualDogs[1], modelDogs[1]);
			Assert.AreEqual(actualDogs[2], modelDogs[2]);
		}
	}
}