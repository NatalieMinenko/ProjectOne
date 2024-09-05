using AutoMapper;
using NailStudio.DAL;
using NailStudioBot.BLL.Mappings;
using NailStudioBot.Core.Dtos;
using NailStudioBot.Core.InputModels;
using NailStudioBot.Core.OutPutModels;

namespace NailStudioBot.BLL
{

    public class UserService
    {
        public UserRepository UserRepository { get; set; }

        private Mapper _mapper;

        public UserService()
        {
            UserRepository = new UserRepository();

            var config = new MapperConfiguration(
                cfg =>
                {
                    cfg.AddProfile(new UsersMappingProfile());
                });
            _mapper = new Mapper(config);
        }

        public void AddUser(UsersInputModel user)
        {
            var userDto = _mapper.Map<UsersDto>(user);

            UserRepository.AddUser(userDto.Name);
        }

        public List<UsersOutputModel> GetAllUsers()
        {
            List<UsersDto> userDtos = UserRepository.GetAllUsers();
            List<UsersOutputModel> users = _mapper.Map<List<UsersOutputModel>>(userDtos);
            return users;
        }

        public UsersOutputModel GetUsersById(int id)
        {
            var userDto = UserRepository.GetUsersById(id);
            return _mapper.Map<UsersOutputModel>(userDto);
        }

        public void UpdateUser(UsersInputModel user)
        {
            var userDto = _mapper.Map<UsersDto>(user);
            UserRepository.UpdateUser(userDto);
        }
    }

}

