﻿using Domain;

public class UserQueryDto : BaseQueryDto
{
    public string Name { get; set; }
    public string Password { get; set; }
    public List<RoleQueryDto> Roles { get; set; }
}


