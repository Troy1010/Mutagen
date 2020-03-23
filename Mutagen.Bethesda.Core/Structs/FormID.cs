﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutagen.Bethesda
{
    /// <summary>
    /// A struct representing a FormID as it exists on disk:
    ///   - The ID of a record (6 bytes)
    ///   - The Mod Index the ID associated with, relative to the container Mod's master header list.
    ///
    /// Note:
    /// FormID should be used sparingly, as it's prone to Mod indexing errors if mishandled.
    /// FormKey is a more preferable struct for normal use.
    /// </summary>
    public struct FormID : IEquatable<FormID>
    {
        /// <summary>
        /// A static readonly singleton that represents a null FormID (all zeros).
        /// </summary>
        public static readonly FormID Null = new FormID();
        
        /// <summary>
        /// The raw uint as it would be stored on disk with both the ID and Mod index.
        /// </summary>
        public readonly uint Raw;
        
        /// <summary>
        /// The ModID bytes of the FormID
        /// </summary>
        public ModID ModID => new ModID(ModID.GetModIDByteFromUInt(this.Raw));
        
        /// <summary>
        /// The ID bytes of a FormID.
        /// Exposed as a uint, but will only ever have values filling the first 6 bytes.
        /// </summary>
        public uint ID => this.Raw & 0x00FFFFFF;

        /// <summary>
        /// Constructor taking a Mod index and ID as separate parameters
        /// </summary>
        /// <param name="modID">Mod index to use</param>
        /// <param name="id">Record ID to use.  Must be <= 0x00FFFFFF.</param>
        /// <exception cref="ArgumentException">ID needs to contain no data in upper two bytes, or it will throw.</exception>
        public FormID(ModID modID, uint id)
        {
            this.Raw = (uint)(modID.ID << 24);
            this.Raw += this.Raw + id & 0x00FFFFFF;
        }

        /// <summary>
        /// Constructor taking a Mod index and ID as a single uint, as it would be stored on-disk.
        /// Mod index is stored in the upper two bytes of the value.
        /// </summary>
        /// <param name="idWithModID">Mod index and Record ID to use</param>
        public FormID(uint idWithModID)
        {
            this.Raw = idWithModID;
        }
        /// <summary>
        /// Converts a string in hexadecimal format to a FormID
        /// </summary>
        /// <param name="hexString">String in hexadecimal format: (0x)FFFFFFFF</param>
        /// <returns>Converted FormID</returns>
        /// <exception cref="ArgumentException">Thrown on unconvertable string input</exception>
        public static FormID Factory(string hexString)
        {
            if (!TryFactory(hexString, out var result))
            {
                throw new ArgumentException($"Invalid FormID hex: {hexString}");
            }
            return result;
        }

        /// <summary>
        /// Attempts to convert a string in hexadecimal format to a FormID
        /// </summary>
        /// <param name="hexString">String in hexadecimal format: (0x)FFFFFFFF</param>
        /// <param name="id">Converted FormID if successful</param>
        /// <returns>True if successful</returns>
        public static bool TryFactory(string hexString, [MaybeNullWhen(false)] out FormID id)
        {
            if (hexString.StartsWith("0x"))
            {
                hexString = hexString.Substring(2);
            }

            if (hexString.Length != 8)
            {
                id = default;
                return false;
            }

            try
            {
                id = new FormID(
                    Convert.ToUInt32(hexString, 16));
                return true;
            }
            catch (Exception)
            {
                id = default;
                return false;
            }
        }

        /// <summary>
        /// Convert an array to a FormID
        /// </summary>
        /// <param name="bytes">Input byte array</param>
        /// <returns>Converted FormID</returns>
        /// <exception cref="ArgumentException">Thrown if array size less than 4</exception>
        public static FormID Factory(byte[] bytes)
        {
            return Factory(BitConverter.ToUInt32(bytes, 0));
        }

        /// <summary>
        /// Wrap a uint with a FormID
        /// </summary>
        /// <param name="idWithModID">Mod index and Record ID to use</param>
        /// <returns>Converted FormID</returns>
        public static FormID Factory(uint idWithModID)
        {
            return new FormID(idWithModID);
        }

        /// <summary>
        /// Converts to a byte array of size 4.
        /// </summary>
        /// <returns>byte array of size 4 with raw contents</returns>
        public byte[] ToBytes()
        {
            return BitConverter.GetBytes(this.Raw);
        }

        /// <summary>
        /// Converts to a hex string: FFFFFFFF
        /// </summary>
        /// <returns>Hex string</returns>
        public string ToHex()
        {
            return $"{ModID}{IDString()}";
        }

        /// <summary>
        /// Converts to a hex string: FFFFFFFF
        /// </summary>
        /// <returns>Hex string</returns>
        public override string ToString()
        {
            return $"({ModID}){IDString()}";
        }

        /// <summary>
        /// Converts to a hex string containing only the ID section: FFFFFF
        /// </summary>
        /// <returns>Hex string</returns>
        public string IDString()
        {
            return ID.ToString("X6");
        }

        /// <summary>
        /// Default equality operator
        /// </summary>
        /// <param name="obj">object to compare to</param>
        /// <returns>True if FormID with equal raw value</returns>
        public override bool Equals(object obj)
        {
            if (!(obj is FormID formID)) return false;
            return Equals(formID);
        }

        /// <summary>
        /// FormID equality operator
        /// </summary>
        /// <param name="other">FormID to compare to</param>
        /// <returns>True equal raw value</returns>
        public bool Equals(FormID other)
        {
            return this.Raw == other.Raw;
        }

        /// <summary>
        /// Hashcode retrieved from Raw value.
        /// </summary>
        /// <returns>Hashcode retrieved from Raw value.</returns>
        public override int GetHashCode()
        {
            return this.Raw.GetHashCode();
        }

        public static bool operator ==(FormID a, FormID b)
        {
            return a.Raw == b.Raw;
        }

        public static bool operator !=(FormID a, FormID b)
        {
            return !(a == b);
        }
    }
}
