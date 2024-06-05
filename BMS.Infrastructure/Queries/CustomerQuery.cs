﻿namespace BMS.Infrastructure.Queries
{
    internal class CustomerQuery
    {
        public static string InsertQuery { get; } = @"INSERT INTO [dbo].[Tbl_Customer]
                                            ([Name]
                                            ,[Email]
                                            ,[Address]
                                            ,[PhoneNumber])
                                        VALUES
                                            (@Name
                                            ,@Email
                                            ,@Address
                                            ,@PhoneNumber)";

        public static string SelectAllQuery { get; } = @"SELECT [CustomerId]
                                                    ,[Name]
                                                    ,[Email]
                                                    ,[Address]
                                                    ,[PhoneNumber]
                                                FROM [dbo].[Tbl_Customer]";

        public static string SelectQuery { get; } = @"SELECT [CustomerId]
                                                    ,[Name]
                                                    ,[Email]
                                                    ,[Address]
                                                    ,[PhoneNumber]
                                                FROM [dbo].[Tbl_Customer]
                                                WHERE CustomerId = @CustomerId";

        public static string UpdateQuery { get; } = @"UPDATE [dbo].[Tbl_Customer]
                                                SET [Name] = @Name
                                                    ,[Email] = @Email
                                                    ,[Address] = @Address
                                                    ,[PhoneNumber] = @PhoneNumber
                                                WHERE CustomerId = @CustomerId";

        public static string DeleteQuery { get; } = @"DELETE FROM [dbo].[Tbl_Customer]
                                                WHERE CustomerId = @CustomerId";
    }
}