/// <summary>
/// Класс для хранения данных о расходах и доходах
/// для второй диаграммы (круговая)
/// </summary>
public class ExpenseIncome
{
    /// <summary>
    /// Передаёт или задёт имя сегмента диаграммы
    /// </summary>
    public string Label { get; set; }

    /// <summary>
    /// Передаёт или задаёт размер сегмента
    /// </summary>
    public double Value { get; set; }
}
