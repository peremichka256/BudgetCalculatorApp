using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BudgetCalculatorApp;
using NUnit.Framework;

namespace BudgetCalculatorAppUnitTests
{
    [TestFixture]
    public class TransactionCategoryTests
    {
        /// <summary>
        /// Объект класса для тестов
        /// </summary>
        private TransactionCategory _testCategory = 
            new TransactionCategory("test", TransactionTypes.Arrival);

        [Test(Description = "Позитивный тест на сеттер имени категории")]
        public void TestCategoryNameSet()
        {
            var newName = "newTestName";
            _testCategory.Name = newName;

            Assert.AreEqual(newName, _testCategory.Name,
                "Имя категории присвоено неверно");
        }

        [Test(Description = "Позитивный тест на сеттер типа категории")]
        public void TestCategoryTypeSet()
        {
            var newType = TransactionTypes.Expense;
            _testCategory.Type = newType;

            Assert.AreEqual(newType, _testCategory.Type,
                "Тип категории присвоен неверно");
        }

        [Test(Description = "Позитивный тест на сеттер Id категории")]
        public void TestCategoryIdSet()
        {
            var newId = 1;
            _testCategory.Id = newId;

            Assert.AreEqual(newId, _testCategory.Id,
                "Id категории присвоен неверно");
        }

        [Test(Description = "Позитивный тест на сеттер транзакции категории")]
        public void TestCategoryTranasctionSet()
        {
            var newTransaction = new List<Transaction>{
                new Transaction(new TransactionCategory(
                    "newName", TransactionTypes.Arrival), 
                    1.0, DateTime.Now)};
            _testCategory.Transactions = newTransaction;

            Assert.AreEqual(newTransaction, _testCategory.Transactions,
                "Список транзакций категории присвоен неверно");
        }

        [Test(Description = "Позитивный тест на геттер имени транзакции" +
                            " через переопределнный ToString()")]
        public void TestCategoryToStringGet()
        {
            var newName = "testNameForToString";
            _testCategory.Name = newName;

            Assert.AreEqual(newName, _testCategory.ToString(),
                "Имя категории возвращено неверно");
        }
    }
}
