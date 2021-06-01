using System.Collections.Generic;
using System.Threading.Tasks;
using ILenguage.API.Domain.Models;
using ILenguage.API.Domain.Services.Communications;

namespace ILenguage.API.Domain.Services
{
    public interface ITopicOfInterestService
    {
        Task<IEnumerable<TopicsOfInterest>> ListAsync();
        Task<IEnumerable<TopicsOfInterest>> ListByUserIdAsyn(int userId);
        Task<TopicsOfInterestResponse> GetById(int topicId);
        Task<TopicsOfInterestResponse> SaveAsync(TopicsOfInterest topicOf);
        Task<TopicsOfInterestResponse> Update(int topicId, TopicsOfInterest topicOf);
        Task<TopicsOfInterestResponse> Delete(int topicId);
    }
}