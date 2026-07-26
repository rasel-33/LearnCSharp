namespace Phase2.FinalTask;

public record ParkingData(Guid Id, DateTime EntryTime, DateTime? ExitTime, Vehicle Vehicle, string ParkingSpotId)
{
    public decimal CalculateParkingFee()
    {
        if (ExitTime is null)
        {
            throw new InvalidOperationException("Vehicle has not exited yet.");
        }
        TimeSpan duration = ExitTime.Value - EntryTime;
        decimal totalHours = (decimal)duration.TotalHours;
        return totalHours * Vehicle.HourlyRate;
    }
}