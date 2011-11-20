namespace Swtor.Business.Entities.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class TestMigration : IDbMigrationMetadata
    {
        string IDbMigrationMetadata.Id
        {
            get { return "201111192357030_TestMigration"; }
        }
        
        string IDbMigrationMetadata.Source
        {
            get { return "H4sIAAAAAAAEAOy9B2AcSZYlJi9tynt/SvVK1+B0oQiAYBMk2JBAEOzBiM3mkuwdaUcjKasqgcplVmVdZhZAzO2dvPfee++999577733ujudTif33/8/XGZkAWz2zkrayZ4hgKrIHz9+fB8/Iv7Hv/cffPx7vFuU6WVeN0W1/Oyj3fHOR2m+nFazYnnx2Ufr9nz74KPf4+g3Th6fzhbv0p807fbQjt5cNp99NG/b1aO7d5vpPF9kzXhRTOuqqc7b8bRa3M1m1d29nZ2Du7s7d3MC8RHBStPHr9bLtljk/Af9eVItp/mqXWflF9UsLxv9nL55zVDTF9kib1bZNP/so9dXbVWPn6ybYpk3zfiUALVF3nyUHpdFRui8zsvz98Rt5yFw+8j2Sv0y2Os316uc+/7so6+avPZbUJvfK78OPqCPXtbVKq/b61f5uffe2eyj9G747t3uy/bVzntA4bOPzpbtvb2P0hfrsswmJX1wnpVN/lG6+vTRayJH/nm+zOuszWcvs7bNa5qhs1nOQ1BSPFp9ejtqPLy7swdq3M2Wy6rNWpruHvIdVJ8VddMu6VeD7eu2Jvb5KH1WvMtnz/PlRTu3GH+RvTOf0K8fpV8tC+I2eqmt17k/Qvl7c8/Ps5+jjjE7r6rSdjw0Pz6Ux3cdU21ktTf5u/brsBre+zqsZt77/wCrvfi5mGzSTi2N8Ife71Oi8kmdg9amb3z0pgANPoDVMJ6MtGet/bBG5UH2+E5eeJ23Ht+TqnXQRd+OWTt2h9N9GXwWe5n5PYq/xdQZhLtiEYzluDtgOh5/ka1WNE2eKdFP0tdiR062X7+/mVgIjLvTJmItLLa2J6JrdpF3vgVDzXJWmjSd2STD7J3MFr1mt5kX05U/PV1N4QhuWuN3b+771nTcN3cMSgE8o2EtSCR4hDo+QiZmJfXF19OszOoBG3dSlevFcpO93ATFMz8+IO/j28NyBsUH5T69PSRnIbqjk0/7kB7f7VC3O4+eUGvLjqLvcsWteEak8pvgmb7dYlA38Uz8tSG6GmPlUzVu+DZBETviw5BPbg/BGgUfiP3w9nACJe/DCr74IXNLT/92m9jerR7u6NvHqvsCpcw06PrzPWUoTT5KiVCXxYwV4XXT5osxGoxf/6LypCyYyKbBF9myOM+b9k31NkdsQrr660cD1ilpmln5/+aQoAAJbvTINroJ/S56rvzyMqun86zeWmTv7ryvA9N1zz8IWNfl5vF/gBf0/xqH+2dlIl98U2TvOL8fBCvi0M7oD2QCPmgquw5t378K0bKazxfkIadW1BFhOqkIacFQ3eBb+LuD7m4MrDrIX9MT7mvcx3f9PMvjp3lTXDgQyLos8ynCLgfUtDlbnldm9mhEPkamSWdyv8jbjGYzO67b4jybtvT1lNwDDpV+MivX1OR0MclnZ8sv1+1q3R43Tb6YlNf+eB/f3dw/u/shzo+/XOEvz8R8/SEQmgUY8svlk3VRzizezyIMOQACrKdiTFhRqEjgLq4tpBfV8paAlHxP81W+hBJ4ky9WJQFrvly+zi7zYdxupmFIscdPi+yizhY+BeUTxeR1Rj17XVAH/huuP/qT2JWSfEf/TwAAAP//izx2XVkUAAA="; }
        }
        
        string IDbMigrationMetadata.Target
        {
            get { return "H4sIAAAAAAAEAOy9B2AcSZYlJi9tynt/SvVK1+B0oQiAYBMk2JBAEOzBiM3mkuwdaUcjKasqgcplVmVdZhZAzO2dvPfee++999577733ujudTif33/8/XGZkAWz2zkrayZ4hgKrIHz9+fB8/Iv7Hv/cffPx7vFuU6WVeN0W1/Oyj3fHOR2m+nFazYnnx2Ufr9nz74KPf4+g3Th6fzhbv0p807fbQjt5cNp99NG/b1aO7d5vpPF9kzXhRTOuqqc7b8bRa3M1m1d29nZ2Du7s7d3MC8RHBStPHr9bLtljk/Af9eVItp/mqXWflF9UsLxv9nL55zVDTF9kib1bZNP/so9dXbVWPn6ybYpk3zfiUALVF3nyUHpdFRui8zsvz98Rt5yFw+8j2Sv0y2Os316uc+/7so6+avPZbUJvfK78OPqCPXtbVKq/b61f5uffe2eyj9G747t3uy/bVzntA4bOPzpbtvb2P0hfrsswmJX1wnpVN/lG6+vTRayJH/nm+zOuszWcvs7bNa5qhs1nOQ1BSPFp9ejtqPLy7swdq3M2Wy6rNWpruHvIdVJ8VddMu6VeD7eu2Jvb5KH1WvMtnz/PlRTu3GH+RvTOf0K8fpV8tC+I2eqmt17k/Qvl7c8/Ps5+jjjE7r6rSdjw0Pz6Ux3cdU21ktTf5u/brsBre+zqsZt77/wCrvfi5mGzSTi2N8Ife71Oi8kmdg9amb3z0pgANPoDVMJ6MtGet/bBG5UH2+E5eeJ23Ht+TqnXQRd+OWTt2h9N9GXwWe5n5PYq/xdQZhLtiEYzluDtgOh5/ka1WNE2eKdFP0tdiR062X7+/mVgIjLvTJmItLLa2J6JrdpF3vgVDzXJWmjSd2STD7J3MFr1mt5kX05U/PV1N4QhuWuN3b+771nTcN3cMSgE8o2EtSCR4hDo+QiZmJfXF19OszOoBG3dSlevFcpO93ATFMz8+IO/j28NyBsUH5T69PSRnIbqjk0/7kB7f7VC3O4+eUGvLjqLvcsWteEak8pvgmb7dYlA38Uz8tSG6GmPlUzVu+DZBETviw5BPbg/BGgUfiP3w9nACJe/DCr74IXNLT/92m9jerR7u6NvHqvsCpcw06PrzPWUoTT5KiVCXxYwV4XXT5osxGoxf/6LypCyYyKbBF9myOM+b9k31NkdsQrr660cD1ilpmln5/+aQoAAJbvTINroJ/S56rvzyMqun86zeWmTv7ryvA9N1zz8IWNfl5vF/gBf0/xqH+2dlIl98U2TvOL8fBCvi0M7oD2QCPmgquw5t378K0bKazxfkIadW1BFhOqkIacFQ3eBb+LuD7m4MrDrIX9MT7mvcx3f9PMvjp3lTXDgQyLos8ynCLgfUtDlbnldm9mhEPkamSWdyv8jbjGYzO67b4jybtvT1lNwDDpV+MivX1OR0MclnZ8sv1+1q3R43Tb6YlNf+eB/f3dw/u/shzo+/XOEvz8R8/SEQmgUY8svlk3VRzizezyIMOQACrKdiTFhRqEjgLq4tpBfV8paAlHxP81W+hBJ4ky9WJQFrvly+zi7zYdxupmFIscdPi+yizhY+BeUTxeR1Rj17XVAH/huuP/qT2JWSfEf/TwAAAP//izx2XVkUAAA="; }
        }
    }
}
