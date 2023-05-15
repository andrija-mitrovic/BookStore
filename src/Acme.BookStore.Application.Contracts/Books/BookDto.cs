using System;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore.Books
{
    public sealed class BookDto : AuditedEntityDto<Guid>
    {
        public string? Name { get; set; }
        public BookType Type { get; set; }
        public DateTime PublishDate { get; set; }
        public float Price { get; set; }
    }
}
