/// <summary>
/// Класс для хранения данных о категориях расходов
/// для первой диаграммы (столбчатая)
/// </summary>
public class CategoryExpense
{
    /// <summary>
    /// Передаёт или задёт имя категории
    /// </summary>
    public string CategoryName { get; set; }

    /// <summary>
    /// Сумма затрат по данной категории
    /// </summary>
    public double TotalExpense { get; set; }
}