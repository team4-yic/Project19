using System;

public class Attendance
{
	public Attendance(int attendanceID, int staffID, int shiftID, string checkInTime, string checkOutTime)
	{
		AttendanceID = attendanceID;
		StaffID = staffID;
		ShiftID = shiftID;
		CheckInTime = checkInTime;
		CheckOutTime = checkOutTime;
	}

	private int attendanceID;
	private int staffID;
	private int shiftID;
	private string checkInTime;
    private string checkOutTime;

	public int AttendanceID {  get { return attendanceID; } set {attendanceID = value;} }
	public int StaffID { get {return staffID;} set {staffID = value;} }
	public int ShiftID { get {return shiftID;} set {shiftID = value;} }
	public string CheckInTime { get {return checkInTime;} set {checkInTime = value;} }
	public string CheckOutTime {  get {return checkOutTime;} set { checkOutTime = value;} }
}
