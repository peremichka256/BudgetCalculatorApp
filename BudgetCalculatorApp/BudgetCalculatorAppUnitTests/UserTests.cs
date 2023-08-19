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
    public class UserTests
    {
        [Test(Description = "Позитивный тест на геттер" +
                            " и сеттер имени пользователя")]
        public void TestUserNameGetterSetter()
        {
            var userName = "TestUser";
            var newUserName = "NewTestUser";
            var user = new User(userName, "TestSurname",
                DateTime.Now);

            Assert.AreEqual(userName, user.Firstname,
                "Имя пользователя установлено неверно");

            user.Firstname = newUserName;
            Assert.AreEqual(newUserName, user.Firstname,
                "Имя пользователя установлено неверно после изменения");
        }

        [Test(Description = "Позитивный тест на геттер и сеттер фамилии" +
                            " пользователя")]
        public void TestUserSurnameGetterSetter()
        {
            var userSurname = "TestSurname";
            var newUserSurname = "NewTestSurname";
            var user = new User("TestName", userSurname, DateTime.Now);

            Assert.AreEqual(userSurname, user.Surname, "Фамилия пользователя" +
                                                       " установлена неверно");

            user.Surname = newUserSurname;
            Assert.AreEqual(newUserSurname, user.Surname,
                "Фамилия пользователя установлена неверно после изменения");
        }

        [Test(Description = "Позитивный тест на геттер" +
                            " и сеттер даты рождения пользователя")]
        public void TestUserBirthDateGetterSetter()
        {
            var birthDate = DateTime.Parse("1990-01-01");
            var newBirthDate = DateTime.Parse("2000-01-01");
            var user = new User("TestName", "TestSurname",
                birthDate);

            Assert.AreEqual(birthDate, user.BirthDate,
                "Дата рождения пользователя установлена неверно");

            user.BirthDate = newBirthDate;
            Assert.AreEqual(newBirthDate, user.BirthDate,
                "Дата рождения пользователя установлена неверно после изменения");
        }

        [Test(Description = "Позитивный тест на добавление" +
                            " транзакции в список пользователя")]
        public void TestAddTransaction()
        {
            var user = new User("TestName",
                "TestSurname", DateTime.Now);
            var transaction = new Transaction(
                new TransactionCategory("TestCategory",
                    TransactionTypes.Arrival), 100.0, DateTime.Now);

            user.AddTransaction(transaction);

            Assert.AreEqual(1, user.Transactions.Count, 
                "Транзакция не была добавлена в список пользователя");
            Assert.AreEqual(transaction, user.Transactions.FirstOrDefault(),
                "Добавленная транзакция не соответствует ожидаемой");
            Assert.AreEqual(user.Id, transaction.UserId,
                "Внешний ключ UserId в транзакции установлен неверно");
        }

        [Test(Description = "Позитивный тест на удаление транзакции" +
                            " из списка пользователя")]
        public void TestRemoveTransaction()
        {
            var user = new User("TestName", "TestSurname",
                DateTime.Now);
            var transaction = new Transaction(
                new TransactionCategory("TestCategory",
                    TransactionTypes.Arrival), 100.0, DateTime.Now);
            user.AddTransaction(transaction);

            user.RemoveTransaction(transaction);

            Assert.AreEqual(0, user.Transactions.Count,
                "Транзакция не была удалена из списка пользователя");
        }

        [Test(Description = "Позитивный тест на расчёт итоговой" +
                            " суммы расходов и приходов пользователя")]
        public void TestGetTotalSum()
        {
            var user = new User("TestName", "TestSurname",
                DateTime.Now);
            var arrivalTransaction = new Transaction(
                new TransactionCategory("ArrivalCategory",
                    TransactionTypes.Arrival), 100.0, DateTime.Now);
            var expenseTransaction = new Transaction(
                new TransactionCategory("ExpenseCategory",
                    TransactionTypes.Expense), 50.0, DateTime.Now);
            user.AddTransaction(arrivalTransaction);
            user.AddTransaction(expenseTransaction);

            var totalSum = user.GetTotalSum();

            Assert.AreEqual(50.0, totalSum, "Итоговая сумма расчета неверна");
        }

        [Test(Description = "Позитивный тест на расчёт" +
                            " суммы приходных транзакций")]
        public void TestGetTotalArrival()
        {
            var user = new User("TestName",
                "TestSurname", DateTime.Now);
            var arrivalTransaction1 = new Transaction(
                new TransactionCategory("ArrivalCategory",
                    TransactionTypes.Arrival), 100.0, DateTime.Now);
            var arrivalTransaction2 = new Transaction(
                new TransactionCategory("ArrivalCategory",
                    TransactionTypes.Arrival), 200.0, DateTime.Now);
            user.AddTransaction(arrivalTransaction1);
            user.AddTransaction(arrivalTransaction2);

            var totalArrival = user.GetTotalArrival();

            Assert.AreEqual(300.0, totalArrival,
                "Сумма приходных транзакций неверна");
        }

        [Test(Description = "Позитивный тест на расчёт суммы" +
                            " расходных транзакций")]
        public void TestGetTotalExpense()
        {
            var user = new User("TestName", "TestSurname",
                DateTime.Now);
            var expenseTransaction1 = new Transaction(
                new TransactionCategory("ExpenseCategory",
                    TransactionTypes.Expense), 50.0, DateTime.Now);
            var expenseTransaction2 = new Transaction(
                new TransactionCategory("ExpenseCategory",
                    TransactionTypes.Expense), 75.0, DateTime.Now);
            user.AddTransaction(expenseTransaction1);
            user.AddTransaction(expenseTransaction2);

            var totalExpense = user.GetTotalExpense();

            Assert.AreEqual(125.0, totalExpense,
                "Сумма расходных транзакций неверна");
        }

        [Test(Description = "Позитивный тест на правильность формирования" +
                            " строки с именем и фамилией пользователя")]
        public void TestUserToString()
        {
            var userName = "TestName";
            var userSurname = "TestSurname";
            var user = new User(userName, userSurname,
                DateTime.Now);

            var fullName = user.ToString();

            Assert.AreEqual($"{userName} {userSurname}", fullName,
                "Строка с именем и фамилией пользователя" +
                " сформирована неверно");
        }

        [Test(Description = "Позитивный тест на геттер и сеттер Id" +
                            " пользователя")]
        public void TestUserIdGetterSetter()
        {
            var userId = 1;
            var newUserId = 2;
            var user = new User("TestName", "TestSurname",
                DateTime.Now);
            user.Id = userId;

            Assert.AreEqual(userId, user.Id, "Id пользователя установлен " +
                                             "неверно");

            user.Id = newUserId;
            Assert.AreEqual(newUserId, user.Id, "Id пользователя установлен" +
                                                " неверно после изменения");
        }

        [Test(Description = "Позитивный тест на геттер и сеттер списка" +
                            " транзакций пользователя")]
        public void TestUserTransactionsGetterSetter()
        {
            var user = new User("TestName", "TestSurname",
                DateTime.Now);
            var transactions = new List<Transaction>
            {
                new Transaction(new TransactionCategory("TestCategory",
                    TransactionTypes.Arrival), 100.0, DateTime.Now),
                new Transaction(new TransactionCategory("TestCategory",
                    TransactionTypes.Expense), 50.0, DateTime.Now)
            };

            user.Transactions = transactions;

            Assert.AreEqual(transactions, user.Transactions, 
                "Список транзакций пользователя установлен неверно");
        }
    }
}
