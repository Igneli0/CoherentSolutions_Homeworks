using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1_PianoKeyboard.Enum;

namespace Task1_PianoKeyboard
{
    internal struct Key : IComparable<Key>
    {
        public Accidental _accidental;
        public Octave _octave;
        public Note _note;

        public Key (Accidental accidental, Octave octave, Note note)
        {
            _accidental = accidental;
            _octave = octave;
            _note = note;
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Key) || obj is null)
            {
                return false;
            }

            var tempKey = (Key)obj;

            if (this._octave == tempKey._octave)
            {
                if (this._accidental == Accidental.Sharp && tempKey._accidental == Accidental.Flat)
                {
                    if (this._note == Note.A && tempKey._note == Note.B ||
                        this._note == Note.C && tempKey._note == Note.D ||
                        this._note == Note.D && tempKey._note == Note.E ||
                        this._note == Note.F && tempKey._note == Note.G ||
                        this._note == Note.G && tempKey._note == Note.A)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public int CompareTo(Key other)
        {
            if (this._octave == other._octave)
            {
                if (this._note == other._note)
                {
                    return this._accidental.CompareTo(other._accidental);
                }
                else if (this.Equals(other))
                {
                    return 0;
                }
                return this._note.CompareTo(other._note);
            }
            return this._octave.CompareTo(other._note);
        }
        public override string ToString()
        {

            return $"Accidental: {_accidental}, octave: {_octave}, and note: {_note}";
            
        }
    }
}
