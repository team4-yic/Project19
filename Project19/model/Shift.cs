using System;

public class Shift
{
	public Shift(int shiftID, int staffID, string shiftDate, string startTime, string endTime, string status)
	{
		ShiftID = shiftID;
		StaffID = staffID;
		ShiftDate = shiftDate;
		StartTime = startTime;
		EndTime = endTime;
		Status = status;
	}

	private int shiftID;
	private int staffID;
	private string shiftDate;
	private string startTime;
	private string endTime;
	private string status;

	public int ShiftID {  get { return shiftID; } set { shiftID = value; } }
	public int StaffID { get {return staffID; } set { staffID = value; } }
	public string ShiftDate { get { return shiftDate; } set { shiftDate = value; } }
	public string StartTime { get { return startTime; } set { startTime = value; } }
	public string EndTime { get { return endTime; } set { endTime = value; } }
	public string Status { get { return status; } set { status = value; } }
}
