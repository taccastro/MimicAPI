using System.Collections.Generic;

namespace TalkToApi.V1.Models.DTO
{
    public class ListaDTO<T> : BaseDTO
    {
        public List<T> Lista { get; set; }
    }
}
