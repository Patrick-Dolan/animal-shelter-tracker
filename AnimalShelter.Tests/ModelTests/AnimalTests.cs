// using AnimalShelter.Models;
// using Microsoft.VisualStudio.TestTools.UnitTesting;
// using MySql.Data.MySqlClient;
// using System;
// using System.Collections.Generic;

// namespace AnimalShelter.Tests
// {
//   [TestClass]
//   public class AnimalTests : IDisposable
//   {
//     public void Dispose()
//     {
//       Animal.CLearAll();
//     }

//     public AnimalTests()
//     {
//       DBConfiguration.ConnectionString = "server=localhost;user id=root;password=epicodus;port=3306;database=animal_shelter_test;";
//     }

//     [TestMethod]
//     public void GetAll_ReturnEmptyListFromDatabase_AnimalList()
//     {
//       List<Animal> newList = new List<Animal> {};
//       List<Animal> result = Animal.GetAll();
//       CollectionAssert.AreEqual(newList, result);
//     }
//   }
// }
// Example Test Method Structure
//_________________________
// [TestMethod]
// public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
// {
//   // any necessary logic to prep for test; instantiating new classes, etc.
//   Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);
// }