using System;

public class Request
{
	public Request(int requestShiftID, int staffID, string shiftDate, string startTime, string endTime, string requestType, string status)
	{
        RequestShiftID = requestShiftID;
        StaffID = staffID;
        ShiftDate = shiftDate;
        StartTime = startTime;
        EndTime = endTime;
        RequestType = requestType; 
        Status = status;
    }

	private int requestShiftID;
	private int staffID;
	private string shiftDate;
	private string startTime;
    private string endTime;
	private string requestType;
    private string status;

    public int RequestShiftID { get { return requestShiftID; } set { requestShiftID = value; } }
    public int StaffID { get { return staffID; } set { staffID = value; } }
    public string ShiftDate { get { return shiftDate; } set { shiftDate = value; } }
    public string StartTime { get { return startTime; } set { startTime = value; } }
    public string EndTime { get { return endTime; } set { endTime = value; } }
    public string RequestType { get { return requestType; } set { requestType = value; }  }
    public string Status { get { return status; } set { status = value; } }
}
