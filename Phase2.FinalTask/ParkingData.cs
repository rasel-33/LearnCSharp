namespace Phase2.FinalTask;

public record ParkingData(Guid Id, DateTime EntryTime, DateTime ExitTime, Vehicle Vehicle, string ParkingSpotId)
{
    public decimal CalculateParkingFee()
    {
        TimeSpan duration = ExitTime - EntryTime;
        decimal totalHours = (decimal)duration.TotalHours;
        decimal fee = totalHours * Vehicle.HourlyRate;
        return Math.Max(fee, 0); 
    }
}