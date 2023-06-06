using System.Collections.Generic;

namespace MimicAPI.V1.Models.DTO
{
    public abstract class BaseDTO
    {
        public List<LinkDTO> Links { get; set; } = new List<LinkDTO>();
    }
}
