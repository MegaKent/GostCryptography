﻿using System;
using System.Security;

namespace GostCryptography.Base
{
	/// <summary>
	/// Базовый класс для всех алгоритмов генерации псевдослучайной последовательности (Pseudorandom Function, PRF) ГОСТ.
	/// </summary>
	public abstract class GostPRF : IDisposable
	{
		/// <summary>
		/// Конструктор.
		/// </summary>
		/// <param name="providerType">Тип криптографического провайдера.</param>
		[SecuritySafeCritical]
		protected GostPRF(ProviderTypes providerType)
		{
			ProviderType = providerType;
		}


		/// <summary>
		/// Тип криптографического провайдера.
		/// </summary>
		public ProviderTypes ProviderType { get; }


		/// <summary>
		/// Освобождает неуправляемые ресурсы.
		/// </summary>
		protected virtual void Dispose(bool disposing)
		{
		}

		/// <inheritdoc />
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <inheritdoc />
		~GostPRF()
		{
			Dispose(false);
		}
	}
}