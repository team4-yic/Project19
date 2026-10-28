using System;

public class Staff
{
	public Staff(int staffID, string staffName, string passwordHash, string fullName, string email,string phoneNumber, string emproymentDate)
	{
		StaffID = staffID;
		StaffName = staffName;
		PassWordHash = passwordHash;
		FullName = fullName;
		Email = email;
		PhoneNumber = phoneNumber;
		EmproymentDate = emproymentDate;
	}

	private int staffID;
	private string staffName;
	private string passWordHash;
	private string fullName;
	private string email;
	private string phoneNumber;
	private string emproymentDate;

    public int StaffID { get { return staffID; } set { staffID = value; } }
    public string StaffName { get { return staffName; } set { staffName = value; } }
    public string PassWordHash { get { return passWordHash; } set { passWordHash = value; } }
	public string FullName { get { return fullName; } set { fullName = value; } }
	public string Email { get { return email; } set { email = value; } }
	public string PhoneNumber { get { return phoneNumber; } set { phoneNumber = value; } }
	public string EmproymentDate { get { return emproymentDate; } set { emproymentDate = value; } }
}
