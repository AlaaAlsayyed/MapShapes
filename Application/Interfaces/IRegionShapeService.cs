using Application.Common;
using Application.DTOModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IRegionShapeService
    {
     
        ServiceResult<RegionShapeDTO> Add(RegionShapeDTO regionShapeDTO);
 
        ServiceResult<RegionShapeDTO> Update(RegionShapeDTO regionShapeDTO);

        ServiceResult<bool> DeleteById(int id);

        ServiceResult<RegionShapeDTO> GetById(int id);

        ServiceResult<IEnumerable<RegionShapeDTO>> GetAll();
    }
}
