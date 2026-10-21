using System;

public class Admin
{
	public Admin(int adminID, string userName, string passwordHash, string fullName, string email)
	{
		AdminID = adminID;
		UserName = userName;
		PasswordHash = passwordHash;
		FullName = fullName;
		Email = email;
	}

	private int adminID;
	private string userName;
	private string passwordHash;
	private string fullName;
	private string email;

	public int AdminID {  get { return adminID; } set { adminID = value; } }
	public string UserName { get { return userName; } set { userName = value; } }
	public string PasswordHash {  get { return passwordHash; } set { passwordHash = value; } }
	public string FullName { get { return fullName; } set { fullName = value; } }
	public string Email { get { return email; } set { email = value; } }
}
