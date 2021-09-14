namespace Zhalobobot.Common.Models.UsersCommon
{
    public record ContactInformation(string Contact, string? Phone);
    
    /*
     * студент, препод, ... -> Person
     * предмет
     * группа
     * группа как объединение людей
     * id -> UniqueId -> CreateFeedbackProvider (.....) -> id
     */
}