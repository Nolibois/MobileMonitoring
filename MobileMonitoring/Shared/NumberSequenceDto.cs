namespace MobileMonitoring.Shared
{
    public record NumberSequenceDto(int IdNumberSequence, string Company, string NbSequence, int Remaining, bool InUse = false)
    {
        #region For deserialization only
        public NumberSequenceDto() : this(default, "", "", default, false) { }
        #endregion


        public NumberSequenceDto(NumberSequence numberSequence) : this(numberSequence.IdNumberSequence, numberSequence.Company.Name, numberSequence.NbSequence, numberSequence.Remaining, numberSequence.InUse) { }
    }
}
