namespace LibarySystem
{
    /// <summary>
    /// Defines different roles of users in the library system
    /// </summary>
    public enum UserRole
    {
        Admin,
        Librarian,
        Member
    }

    /// <summary>
    /// Represents the current status of a library item
    /// </summary>
    public enum ItemStatus
    {
        Available,
        Borrowed,
        Reserved,
        Lost
    }
}
