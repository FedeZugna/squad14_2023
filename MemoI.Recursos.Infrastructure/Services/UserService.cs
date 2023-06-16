using System.Net.Http.Headers;
using AutoMapper;
using MemoI.Recursos.Application.Contracts.Repositories;
using MemoI.Recursos.Application.Contracts.Services;
using MemoI.Recursos.Application.Dtos.Users;
using MemoI.Recursos.Application.Responses;
using MemoI.Recursos.Domain;
using Newtonsoft.Json;

namespace MemoI.Recursos.Infrastructure.Services;

public class UserService : IUserService
{
    private const string _recursosUrl = "https://anypoint.mulesoft.com/mocking/api/v1/sources/exchange/assets/754f50e8-20d8-4223-bbdc-56d50131d0ae/recursos-psa/1.0.0/m/api/recursos";
    
    public async Task<List<UserDto>> GetUsers()
    {
        try
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            
            using var response = await httpClient.GetAsync(_recursosUrl);
            var responseBody = await response.Content.ReadAsStringAsync();
            
            var userDtos = JsonConvert.DeserializeObject<List<UserDto>>(responseBody);
            if (userDtos != null)
                return userDtos;
        }
        catch (Exception e)
        {
            return new List<UserDto>();
        }
        return new List<UserDto>();
    }
        
}