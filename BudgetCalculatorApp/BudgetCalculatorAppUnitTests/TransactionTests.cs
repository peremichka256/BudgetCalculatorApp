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
    public class TransactionTests
    {
        private Transaction _testTransaction = 
            new Transaction(new TransactionCategory("test",
                TransactionTypes.Arrival), 100.0, DateTime.Now);


        [Test(Description = "Позитивный тест на сеттер категории транзакции")]
        public void TestTransactionCategorySet()
        {
            var newCategory = new TransactionCategory("newCatrgory",
                TransactionTypes.Expense);
            _testTransaction.Category = newCategory;

            Assert.AreEqual(newCategory, _testTransaction.Category,
                "Категория присвоена неверно");
        }

        [Test(Description = "Позитивный тест на сеттер суммы транзакции")]
        public void TestTransactionValueSetPositive()
        {
            var newValue = 202.2;
            _testTransaction.Value = newValue;

            Assert.AreEqual(newValue, _testTransaction.Value,
                "Сумма транзакции присвоена неверно");
        }

        [Test(Description = "Негативный тест на сеттер суммы транзакции")]
        public void TestTransactionValueSetNegative()
        {
            var newUncorrectValue = -202.2;

            Assert.Throws<Exception>(() => 
                { _testTransaction.Value = newUncorrectValue; },
                "При попытке присвоить отрицательное значение должно" +
                " было появится исключение");
        }

        [Test(Description = "Позитивный тест на сеттер даты транзакции")]
        public void TestTransactionDateSet()
        {
            var newDate = DateTime.MaxValue;
            _testTransaction.DateTime = newDate;

            Assert.AreEqual(newDate, _testTransaction.DateTime,
                "Дата транзакции присвоена неверно");
        }

        [Test(Description = "Позитивный тест на сеттер Id транзакции")]
        public void TestTransactionIdSet()
        {
            var newId = 100;
            _testTransaction.Id = newId;

            Assert.AreEqual(newId, _testTransaction.Id,
                "Id транзакции присвоен неверно");
        }

        [Test(Description = "Позитивный тест на сеттер " +
                            "пользователя транзакции")]
        public void TestTransactionUserSet()
        {
            var newUser = new User("a", "b", DateTime.Now);
            _testTransaction.User = newUser;

            Assert.AreEqual(newUser, _testTransaction.User,
                "Пользователь транзакции присвоен неверно");
        }

        [Test(Description = "Позитивный тест на сеттер " +
                            "Id пользователя транзакции")]
        public void TestTransactionUserIdSet()
        {
            var newUserId = 100;
            _testTransaction.UserId = newUserId;

            Assert.AreEqual(newUserId, _testTransaction.UserId,
                "Id пользователя транзакции присвоен неверно");
        }

        [Test(Description = "Позитивный тест на сеттер " +
                            "Id категории транзакции")]
        public void TestTransactionCategoryIdSet()
        {
            var newCategoryId = 1000;
            _testTransaction.CategoryId = newCategoryId;

            Assert.AreEqual(newCategoryId, _testTransaction.CategoryId,
                "Id категории транзакции присвоен неверно");
        }

        [Test(Description = "Позитивный тест на пустой " +
                            "конструктор транзакции")]
        public void TestTransactionConstuctor()
        {
            var newEmptyTransaction = new Transaction();
            Assert.IsNotNull(newEmptyTransaction,
                "Должен был создаться объект транзакции");
        }
    }
}
