﻿namespace SkillApp.Entities.DTO.Login
{
    public class LoginResponse
    {
        public string access_token { get; set; }
        public int expires_in { get; set; }
    }
}