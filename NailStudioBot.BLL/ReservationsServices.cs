using AutoMapper;
using mapper;
using NailStudio.DAL;
using NailStudioBot.BLL.Mappings;
using NailStudioBot.Core.Dtos;
using NailStudioBot.Core.InputModels;
using NailStudioBot.Core.OutPutModels;

namespace NailStudioBot.BLL
{
    public class ReservationsServices
    {
        public ReservationsRepository ReservationsRepository { get; set; }
        private Mapper _mapper;

        public ReservationsServices()
        {
            ReservationsRepository = new ReservationsRepository();
            var config = new MapperConfiguration(
                cfg =>
                {
                    cfg.AddProfile(new ReservationsMappingProfile());
                });
            _mapper = new Mapper(config);
        }

        public void AddReservation(ReservationsInputModel inputModel)
        {
            var reservationDto = _mapper.Map<ReservationsDto>(inputModel);
            ReservationsRepository.InsertReservation(reservationDto);
        }

        public List<ReservationsInputModel> GetAllReservations()
        {
            var reservations = ReservationsRepository.GetAllReservations();
            return _mapper.Map<List<ReservationsInputModel>>(reservations);
        }

        public void UpdateReservation(int id, ReservationsInputModel inputModel)
        {
            var reservationDto = _mapper.Map<ReservationsDto>(inputModel);
            reservationDto.Id = id;
            ReservationsRepository.UpdateReservation(reservationDto);
        }

        public void DeleteReservation(int id)
        {
            ReservationsRepository.DeleteReservationById(id);
        }

    }
}
