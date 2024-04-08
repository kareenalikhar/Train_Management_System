using Train_Management_System.Dto;
using Train_Management_System.Repository;
using Train_Management_System.Models;
namespace Train_Management_System.Services.ServiceImpl
{
    public class TrainServiceImpl : TrainServiceInterface
    {
        public int AddTrain(TrainMasterRequestDto addTrainMasterDto)
        {
            try
            {
                Repository.TrainRepository trainRepository = new Repository.TrainRepository();
                TrainMaster addTrain = new TrainMaster();
                addTrain.Train_Name = addTrainMasterDto.Train_Name;
                addTrain.Train_Capacity = addTrainMasterDto.Train_Capacity;
                addTrain.Train_Status = addTrainMasterDto.Train_Status;
                trainRepository.insertItem(addTrain);
                return 0;
            }
            catch (Exception ex)
            {
                throw new NotImplementedException();
            }
            
        }
    }
}
