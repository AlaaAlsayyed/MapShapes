using Application.Common;
using Application.Interfaces;
using Application.DTOModels;
using AutoMapper;
using System;
using System.Collections.Generic;
using Domain.Interfaces.RepositoryInterfaces;
using System.Linq;
using Domain.Models;
using Domain.Interfaces;

namespace Application.Services
{
    public class RegionShapeService : IRegionShapeService
    {
        private IMapper _mapper;
        private IUnitOfWork _unitOfWork;

        public RegionShapeService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public ServiceResult<RegionShapeDTO> Add(RegionShapeDTO regionShapeDTO)
        {
            ServiceResult<RegionShapeDTO> serviceResult;
            try
            {
                var regionShape = _mapper.Map<RegionShape>(regionShapeDTO);
               // regionShape.Id = Guid.NewGuid();
                _unitOfWork.RegionShapes.Add(regionShape);

                if (_unitOfWork.SaveAllChanges() != 0)
                    serviceResult = new ServiceResult<RegionShapeDTO>(_mapper.Map<RegionShapeDTO>(regionShape), "Item added successfully");
                else
                    serviceResult = new ServiceResult<RegionShapeDTO>(string.Format("Error occured while adding item"));
            }
            catch (Exception ex)
            {
                serviceResult = new ServiceResult<RegionShapeDTO>(ex.Message);
            }
            return serviceResult;
        }

        public ServiceResult<bool> DeleteById(int id)
        {
            ServiceResult<bool> serviceResult;
            try
            {
                var regionShape = _unitOfWork.RegionShapes.Get(id);
                if (regionShape != null)
                {
                    _unitOfWork.RegionShapes.Remove(regionShape);
                    if (_unitOfWork.SaveAllChanges() != 0)
                        serviceResult = new ServiceResult<bool>(true,"Item  deleted successfully");
                    else
                        serviceResult = new ServiceResult<bool>("Error occured while deleting item");
                }
                else
                {
                    serviceResult = new ServiceResult<bool>( string.Format("Item with this id : '{0}' is not exist", id));
                }
            }
            catch (Exception ex)
            {
                serviceResult = new ServiceResult<bool>(ex.Message);
            }
            return serviceResult;
        }

        public ServiceResult<IEnumerable<RegionShapeDTO>> GetAll()
        {
            ServiceResult<IEnumerable<RegionShapeDTO>> serviceResult;
            try
            {
                var regionShapesDTOList = _unitOfWork.RegionShapes.GetAll().Select(e => _mapper.Map<RegionShapeDTO>(e));
                serviceResult = new ServiceResult<IEnumerable<RegionShapeDTO>>(regionShapesDTOList);
            }
            catch (Exception ex)
            {
                serviceResult = new ServiceResult<IEnumerable<RegionShapeDTO>>(ex.Message);
            }
            return serviceResult;
        }

        public ServiceResult<RegionShapeDTO> GetById(int id)
        {
            ServiceResult<RegionShapeDTO> serviceResult;
            try
            {
                var regionShape = _unitOfWork.RegionShapes.Get(id);
                if (regionShape != null)
                {
                    var regionShapeDTO = _mapper.Map<RegionShapeDTO>(regionShape);
                    serviceResult = new ServiceResult<RegionShapeDTO>(regionShapeDTO);
                }
                else
                {
                    serviceResult = new ServiceResult<RegionShapeDTO>(string.Format("Item with this id : '{0}' is not exist", id));
                }
            }
            catch (Exception ex)
            {
                serviceResult = new ServiceResult<RegionShapeDTO>(ex.Message);
            }
            return serviceResult;
        }

        public ServiceResult<RegionShapeDTO> Update(RegionShapeDTO regionShapeDTO)
        {
            ServiceResult<RegionShapeDTO> serviceResult;
            try
            {
                var regionShape = _unitOfWork.RegionShapes.Get(regionShapeDTO.Id);

                if (regionShape != null)
                {
                    regionShape.Name = regionShapeDTO.Name;

                    if (_unitOfWork.SaveAllChanges() != 0)
                    {
                        serviceResult = new ServiceResult<RegionShapeDTO>(regionShapeDTO, "Item updated successfully");
                    }
                    else
                    {
                        serviceResult = new ServiceResult<RegionShapeDTO>("Error Occured while updating item");
                    }
                }
                else
                {
                    serviceResult = new ServiceResult<RegionShapeDTO>(string.Format("Item with this id : '{0}' is not exist", regionShape.Id));
                }
            }
            catch (Exception ex)
            {
                serviceResult = new ServiceResult<RegionShapeDTO>(ex.Message);
            }
            return serviceResult;
        }
    }
}
