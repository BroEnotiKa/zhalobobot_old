namespace Zhalobobot.Common.Models.User
{
    public record ContactInformation(string Login, string? Phone);
    
    /*
     * студент, препод, ... -> Person
     * предмет
     * группа
     * группа как объединение людей
     * id -> UniqueId -> CreateFeedbackProvider (.....) -> id
     */
}