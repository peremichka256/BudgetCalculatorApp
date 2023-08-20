using System.Linq;
using BudgetCalculatorApp;

namespace DBWrapper
{
    /// <summary>
    /// Класс для предотвращения повторнго внесения данных
    /// </summary>
    public static class AppContextExtensions
    {
        /// <summary>
        /// Метод не допускающий добавления уже существующей категории
        /// и создающий новую, если её не существует
        /// </summary>
        /// <param name="context">Контекст БД</param>
        /// <param name="categoryName">Имя категории</param>
        /// <param name="categoryType">Типа категории</param>
        /// <returns>Созданная категоря</returns>
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