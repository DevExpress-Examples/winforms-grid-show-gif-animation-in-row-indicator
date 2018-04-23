using System.Drawing;
using System.Drawing.Imaging;

namespace DataGridWinApp1
{
	public class AnimatedGifImageHelper
	{
		private Image gif;
		private FrameDimension frameDimension;
		private int frameCount;
		private int currentFrame = -1;

		public AnimatedGifImageHelper(string path)
		{
			gif = Image.FromFile(path);
			frameDimension = new FrameDimension(gif.FrameDimensionsList[0]);
			frameCount = gif.GetFrameCount(frameDimension);
		}

		public Image GetFrame(int index)
		{
			gif.SelectActiveFrame(frameDimension, index);
			return gif.Clone() as Image;
		}

		public Image GetNextFrame()
		{
			currentFrame++;
			if ( currentFrame >= frameCount || currentFrame < 1 )
				currentFrame = 0;

			return GetFrame(currentFrame);
		}
	}
}
