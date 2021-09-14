using System;
using System.Linq;
using Zhalobobot.Common.Models.Entities;

namespace Zhalobobot.Common.Models.Helpers
{
    public static class EntityKindHelper
    {
        public static byte[] ToByteArray(this EntityKind kind)
        {
            var bytes = BitConverter.GetBytes((uint)kind);

            if (!BitConverter.IsLittleEndian)
                Array.Reverse(bytes);

            return bytes;
        }

        public static EntityKind ToEntityKind(this byte[] bytes, int offset)
        {
            if (!BitConverter.IsLittleEndian)
            {
                bytes = bytes.Skip(offset).Take(4).Reverse().ToArray();
                offset = 0;
            }

            return (EntityKind)BitConverter.ToUInt32(bytes, offset);
        }
    }
}