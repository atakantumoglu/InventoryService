namespace InventoryService.Application.Dtos.PersonelDtos
{
    public class PersonelResponseDto
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Title { get; set; }
        public string TCKN { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
