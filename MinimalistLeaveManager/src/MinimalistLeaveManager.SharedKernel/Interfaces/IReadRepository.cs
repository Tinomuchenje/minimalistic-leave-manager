﻿using Ardalis.Specification;

namespace MinimalistLeaveManager.SharedKernel.Interfaces;

public interface IReadRepository<T> : IReadRepositoryBase<T> where T : class, IAggregateRoot
{
}
