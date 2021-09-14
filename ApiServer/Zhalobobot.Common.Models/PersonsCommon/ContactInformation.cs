namespace Zhalobobot.Common.Models.PersonsCommon
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