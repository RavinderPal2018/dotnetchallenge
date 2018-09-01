using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DotnetChallenge.Controllers;
using DotnetChallenge.Repo;
using DotnetChallenge.Repo.Entities;

namespace DotnetChallenge.Tests
{
    [TestClass]
    public class TestPersonController
    {
        IPersonRepository _personRepository;
        public TestPersonController()
        {
            _personRepository = new PersonRepository();
        }
        /// <summary>
        /// Unit test Person webapi return name correctly
        /// Input  : Name :John Smith , Amount :123.45
        /// Output : Name :John Smith
        /// </summary>
        [TestMethod]
        public void GetPerson_Name_Returns_Correctly()
        {
            PersonController personController = new PersonController(_personRepository);
            Person person = personController.GetPerson("John Smith", "123.45");
            Assert.AreEqual(person.Name, "John Smith");
        }
        /// <summary>
        ///  Unit test Person webapi return amount correctly
        ///  Input  : Name :John Smith , Amount :123.45
        ///  Output : Amount : ONE HUNDRED TWENTY-THREE DOLLARS AND FOURTY-FIVE CENTS
        /// </summary>
        [TestMethod]
        public void GetPerson_Amount_Returns_Correctly()
        {
            PersonController personController = new PersonController(_personRepository);
            Person person= personController.GetPerson("John Smith", "123.45");
            Assert.AreEqual(person.Amount, "ONE HUNDRED TWENTY-THREE DOLLARS AND FOURTY-FIVE CENTS");
        }
        /// <summary>
        ///  Unit test Person webapi return name and amount correctly
        ///  Input  : Name :John Smith , Amount :123.45
        ///  Output : Name :John Smith , Amount : ONE HUNDRED TWENTY-THREE DOLLARS AND FOURTY-FIVE CENTS
        /// </summary>
        [TestMethod]
        public void GetPerson_Return_Amount_Name_Correctly()
        {
            PersonController personController = new PersonController(_personRepository);
            Person person = personController.GetPerson("John Smith", "123.45");
            Assert.AreEqual(person.Name, "John Smith");
            Assert.AreEqual(person.Amount, "ONE HUNDRED TWENTY-THREE DOLLARS AND FOURTY-FIVE CENTS");
        }
    }
}
