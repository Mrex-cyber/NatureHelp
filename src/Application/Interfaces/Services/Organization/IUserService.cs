﻿using Domain.Models.Organization;

namespace Application.Interfaces.Services.Organization;
public interface IUserService
{
    public Task<User> RegisterAsync();
    public Task<User> LoginAsync(User user);
}
