using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Text;
using System.Threading.Tasks;

namespace Common.Controls;

public class AlbumArtworkPanelConstrol : Control
{
    public AlbumArtworkPanelConstrol()
    {
        this.DefaultStyleKey = typeof(AlbumArtworkPanelConstrol);
    }

    public ImageSource? AlbumArtImage
    {
      
    }
}