using System.Linq;
using BudgetCalculatorApp;

namespace DBWrapper
{
    public static class AppContextExtensions
    {
        public static TransactionCategory GetOrCreateCategory(AppContext context, string categoryName, TransactionTypes categoryType)
        {
            var existingCategory = context.TransactionCategories
                .FirstOrDefault(c => c.Name == categoryName && c.Type == categoryType);

            if (existingCategory != null)
            {
                return existingCategory; // Возвращаем существующую категорию
            }
            else
            {
                // Создаем новую категорию, но не добавляем её в контекст
                var newCategory = new TransactionCategory(categoryName, categoryType);
                return newCategory; // Возвращаем новую категорию
            }
        }
    }
}