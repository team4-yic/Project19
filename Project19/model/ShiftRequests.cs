using System;

public class ShiftRequests
{
	public ShiftRequests(int requestID, int staffID, int originalShiftID, int requestedShiftID, string requestDate, string status)
	{
		RequestID = requestID;
		StaffID = staffID;
		OriginalShiftID = originalShiftID;
		RequestedShiftID = requestedShiftID;
		RequestDate = requestDate;
		Status = status;
	}

	private int requesetID;
	private int staffID;
	private int originalShiftID;
	private int requestedShiftID;
	private string requestDate;
	private string status;

	public int RequestID { get { return requesetID; } set { requesetID = value; } }
	public int StaffID { get {return staffID; } set { staffID = value; } }
	public string OriginalShiftID{ get { return originalShiftID; } set { originalShiftID  = value; }  }
	public string RequestedShiftID { get { return requestedShiftID; } set { requestedShiftID = value; } }
	public string RequestDate { get { return requestDate; } set { requestDate = value; } }
	public string Status { get { return status; } set { status = value; } }
}
